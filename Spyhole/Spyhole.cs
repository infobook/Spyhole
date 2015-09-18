using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using CommandAS.Tools;
using CommandAS.QueryLib;

namespace Spyhole
{
  public class Spyhole
  {
    public class CurrentState
    {
      public int Code;
      public string Text;
      public bool IsFlag;

      public CurrentState(int aCode, string aText, bool aIsFlag)
      {
        Code = aCode;
        Text = aText;
        IsFlag = aIsFlag;
      }
      public CurrentState()
        : this (0, null, false)
      {
      }
      public CurrentState(string aText)
        : this(0, aText, false)
      {
      }
    }

    public const string SESSION_FOLDER_SPYHOLE = "dirSpyhole";

    private Performer qp;
    private bool _isSesLoaded;
    private int _intervalSec;

    public string pSessionFileName
    {
      set
      {
        _isSesLoaded = qp.Load(value);
      }
    }

    public int pPauseIntevalInSeconds
    {
      set { _intervalSec = value; }
    }

    public Spyhole()
    {
      qp = new Performer();
      _isSesLoaded = false;
      _intervalSec = 1;
    }

    /// <summary>
    /// MAIN function.
    /// Note: in [...ReportProgress(0,...]
    /// 0 - trace message
    /// 1 - journal message
    /// 2 - count
    /// </summary>
    /// <param name="aBW"></param>
    /// <param name="e"></param>
    public void Run(BackgroundWorker aBW, DoWorkEventArgs e)
    {
      aBW.ReportProgress(1, new CurrentState("Begining !!!"));
      if (_isSesLoaded)
      {
        frmResult frm = new frmResult();

        ArrayList al = new ArrayList();
        string tvSep = (new ucPCParamTV(qp)).PathSeparator;
        foreach (Query qq in qp.pQueries)
        {
          string[] ss = qq.Name.Split(tvSep.ToCharArray());
          if (ss.Length > 1 && ss[0].Equals(SESSION_FOLDER_SPYHOLE))
            al.Add(new _ListBoxItem(qq.Code, ss[1]));
        }

        qp.pWDB.pConnectionString = qp.pSes.DBConnection;
        CurrentState state = new CurrentState();
        long count = 0;
        while (true)
        {
          if (aBW.CancellationPending)
          {
            e.Cancel = true;
            break;
          }
          else
          {
            qp.pWDB.ConnectionOpen();
            foreach (_ListBoxItem li in al)
            {
              try
              {
                if (li.code > 0 && qp.SetCurrentQueryByCode(li.code))
                {
                  qp.pCurrentQuery.SetParamDefaultValueAsCurrent();
                  qp.Execute();
                  state.Code++;
                  state.Text = qp.pCurrentQuery.Name;
                  state.IsFlag = false;
                  if (qp.pResultSet != null && qp.pResultSet.Tables.Count > 0)
                  {
                    foreach (DataTable tab in qp.pResultSet.Tables)
                      if (tab.Rows.Count > 0)
                      {
                        state.IsFlag = true;
                        break;
                      }
                  }
                  if (state.IsFlag)
                  {
                    frm.pQueryPerformer = qp;
                    frm.ShowDialog();
                    
                  }
                  aBW.ReportProgress(0, state);
                }
              }
              catch (Exception ex)
              {
                aBW.ReportProgress(0, new CurrentState(ex.Message));
              }
            }
            qp.pWDB.ConnectionClose();
            aBW.ReportProgress(2, new CurrentState(""+(count == long.MaxValue? 0 : count++)));

            if (_intervalSec > 0)
              System.Threading.Thread.Sleep(_intervalSec * 1000);
          }
        }
      }
      else
      {
        if (qp.pError.IsError)
          aBW.ReportProgress(1, new CurrentState(qp.pError.text));
      }
      aBW.ReportProgress(1, new CurrentState("Finish ..."));
    }
  }
}

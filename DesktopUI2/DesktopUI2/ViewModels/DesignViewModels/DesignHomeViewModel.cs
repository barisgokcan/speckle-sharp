﻿using DesktopUI2.Models;
using Speckle.Core.Api;
using Speckle.Core.Credentials;
using System.Collections.Generic;
using System.Linq;

namespace DesktopUI2.ViewModels.DesignViewModels
{
  public class DesignHomeViewModel
  {
    public bool InProgress { get; set; } = false;

    public Account SelectedAccount { get; set; } = null;

    public List<Account> Accounts { get; set; } = new List<Account>();

    public string SearchQuery { get; set; }

    public List<StreamAccountWrapper> Streams { get; set; } = new List<StreamAccountWrapper>();

    public List<DesignSavedStreamViewModel> SavedStreams { get; set; }

    public bool HasSavedStreams = true;

    public DesignHomeViewModel()
    {
      var acc = AccountManager.GetDefaultAccount();
      var client = new Client(acc);
      Streams = client.StreamsGet().Result.Select(x => new StreamAccountWrapper(x, acc)).ToList();

      var d = new DesignSavedStreamsViewModel();
      SavedStreams = d.SavedStreams;
      //SavedStreams = new List<SavedStreamViewModel>();

      //var streamState = new StreamState(Streams.First());
      //var savedState = new SavedStreamViewModel(streamState, null, null);
      //SavedStreams.Add(savedState);
    }

    public void NewStreamCommand()
    {

    }

    public void AddFromUrlCommand()
    {
    }
  }


}

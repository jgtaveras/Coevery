﻿using System.Collections.Generic;
using Orchard.ContentManagement;

namespace Orchard.Lists.ViewModels {
    public class ListContentsViewModel  {
        public ListContentsViewModel() {
            Options = new ContentOptions();
        }

        public string FilterByContentType { get; set; }
        public int? ContainerId { get; set; }
        public string ContainerDisplayName { get; set; }

        public int? Page { get; set; }
        public IList<Entry> Entries { get; set; }
        public ContentOptions Options { get; set; }

        #region Nested type: Entry

        public class Entry {
            public ContentItem ContentItem { get; set; }
            public ContentItemMetadata ContentItemMetadata { get; set; }
        }

        #endregion
    }

    public class ContentOptions {
        public ContentOptions() {
            OrderBy = ContentsOrder.Modified;
            BulkAction = ContentsBulkAction.None;
        }
        public string SelectedFilter { get; set; }
        public IEnumerable<KeyValuePair<string, string>> FilterOptions { get; set; }
        public ContentsOrder OrderBy { get; set; }
        public ContentsBulkAction BulkAction { get; set; }
    }

    public enum ContentsOrder {
        Modified,
        Published,
        Created
    }

    public enum ContentsBulkAction {
        None,
        PublishNow,
        Unpublish,
        Remove,
        RemoveFromList,
        MoveToList
    }
}
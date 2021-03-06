﻿using System;
using System.Collections.Generic;
using Exceptionless.Core.Models;
using Exceptionless.Core.Models.Data;

namespace Exceptionless.Core.Plugins.Formatting {
    public abstract class FormattingPluginBase : PluginBase, IFormattingPlugin {
        public virtual SummaryData GetStackSummaryData(Stack stack) {
            return null;
        }

        public virtual SummaryData GetEventSummaryData(PersistentEvent ev) {
            return null;
        }

        public virtual string GetStackTitle(PersistentEvent ev) {
            return null;
        }

        public virtual MailMessageData GetEventNotificationMailMessageData(PersistentEvent ev, bool isCritical, bool isNew, bool isRegression) {
            return null;
        }

        protected void AddUserIdentitySummaryData(Dictionary<string, object> data, UserInfo identity) {
            if (identity == null)
                return;

            if (!String.IsNullOrEmpty(identity.Identity))
                data.Add("Identity", identity.Identity);

            if (!String.IsNullOrEmpty(identity.Name))
                data.Add("Name", identity.Name);
        }
    }
}
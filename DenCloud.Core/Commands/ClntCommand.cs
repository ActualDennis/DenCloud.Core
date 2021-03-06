﻿using DenCloud.Core.Data;
using DenCloud.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenCloud.Core.Commands {
    public class ClntCommand : FtpCommand {
        public ClntCommand(ControlConnection controlConnection, ILogger logger) : base(controlConnection)
        {
            this.logger = logger;
        }

        private ILogger logger { get; set; }

        public async override Task<FtpReply> Execute(string parameter)
        {
            logger.Log($"{controlConnection.ClientInitialRemoteEndPoint.ToString()} connected via {parameter}.", RecordKind.Status);
            return new FtpReply() { ReplyCode = FtpReplyCode.Okay, Message = $"Accepted information about client." };
        }
    }
}

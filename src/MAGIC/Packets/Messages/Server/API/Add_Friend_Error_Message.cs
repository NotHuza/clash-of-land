namespace ClashLand.Packets.Messages.Server.Friend
{
    using ClashLand.Logic;
    using ClashLand.Logic.Enums;
    using ClashLand.Extensions.List;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ClashLand.Core;
    using ClashLand.Core.Database;
    using ClashLand.Extensions;

    internal class Add_Friend_Error_Message : Message
    {
        private AddFriendErrorReason Reason;

        /// <summary>
        /// Gets a value indicating the message type.
        /// </summary>
        /*internal override short Type
        {
            get
            {
                return 20112;
            }
        }*/

        /// <summary>
        /// Gets a value indicating the service node of message.
        /// </summary>
        /*internal override ServiceNode Node
        {
            get
            {
                return ServiceNode.Friend;
            }
        }*/

        /// <summary>
        /// Initializes a new instance of the <see cref="Add_Friend_Error_Message"/> class.
        /// </summary>
        /// <param name="Device">The device.</param>
        /// <param name="Command">The command.</param>
        public Add_Friend_Error_Message(Device Device, AddFriendErrorReason Reason) : base(Device)
        {
            this.Reason     = Reason;
        }

        /// <summary>
        /// Encodes the <see cref="Message" />, using the <see cref="Writer" /> instance.
        /// </summary>
        internal override void Encode()
        {
            this.Data.AddInt((int) this.Reason);
        }
    }
}
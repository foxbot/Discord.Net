﻿using System.Threading.Tasks;

namespace Discord
{
    public interface IDMChannel : IMessageChannel, IUpdateable
    {
        /// <summary> Gets the recipient of all messages in this channel. </summary>
        IUser Recipient { get; }

        /// <summary> Closes this private channel, removing it from your channel list. </summary>
        Task CloseAsync();
    }
}
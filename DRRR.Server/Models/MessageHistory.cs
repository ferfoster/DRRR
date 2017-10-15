﻿using System;
using System.Collections.Generic;

namespace DRRR.Server.Models
{
    public partial class MessageHistory
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public long UnixTimeMilliseconds { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
    }
}

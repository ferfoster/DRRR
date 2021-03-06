﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRRR.Server.Dtos
{
    /// <summary>
    /// 聊天室列表检索响应DTO
    /// </summary>
    public class ChatRoomSearchResponseDto
    {
        /// <summary>
        /// 聊天室列表
        /// </summary>
        public List<ChatRoomDto> ChatRoomList { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        public PaginationDto Pagination { get; set; }
    }
}

﻿// -------------------------------------------------------------------------------------------------------------------
// <copyright company="Gemotial" file="NetGroup.cs" project="NetDevPL.Features.NetGroups" date="2016-09-29 23:06">
// 
// </copyright>
// -------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NetDevPL.Features.NetGroups
{

    public class NetGroup
    {
        public string Name { get; set; }
        public string MeetupName { get; set; }
        public string City { get; set; }
        public string WebSite { get; set; }
        public List<NetGroupMeeting> UpcomingMeetings { get; set; }
    }
}
﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace osu.Game.Online.API.Requests.Responses
{
    public class APIChangelogChart
    {
        [JsonProperty("build_history")]
        public List<BuildHistory> BuildHistory { get; set; }

        [JsonProperty("order")]
        public List<string> Order { get; set; }

        [JsonProperty("stream_name")]
        public string StreamName { get; set; }
    }

    public class BuildHistory
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("user_count")]
        public long UserCount { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }
}

﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Online.API.Requests.Responses;

namespace osu.Game.Online.API.Requests
{
    public class GetChangelogRequest : APIRequest<APIChangelogBuild[]>
    {
        protected override string Target => @"changelog";
        protected override string Uri => $@"https://houtarouoreki.github.io/fake-api/{Target}/index"; // for testing
    }
}

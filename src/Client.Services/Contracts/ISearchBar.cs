﻿using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services.Contracts;

public interface ISearchBar
{
    Task<IGraphServiceUsersCollectionPage> FindUser(string UserName, GraphServiceClient graphClient);
}
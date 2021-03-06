﻿using System.Collections.Generic;
using Oqtane.Models;

namespace Oqtane.Repository
{
    public interface IModuleDefinitionRepository
    {
        IEnumerable<ModuleDefinition> GetModuleDefinitions();
    }
}

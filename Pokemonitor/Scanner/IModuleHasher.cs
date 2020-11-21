using System;

namespace Pokemonitor.Scanner
{
    interface IModuleHasher
    {
        string HashModule(ModuleHandle module);
    }
}

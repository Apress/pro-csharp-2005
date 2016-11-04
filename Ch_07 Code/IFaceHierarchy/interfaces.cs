#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace IFaceHierarchy
{
    // The base interface.
    interface IDrawable
    { void Draw();}

    interface IPrintable : IDrawable
    { void Print(); }

    interface IMetaFileRender : IPrintable
    { void Render(); }

    interface ICar
    { void Drive(); }

    interface IUnderwaterCar
    { void Dive(); }

    // Here we have an interface with TWO base interfaces.
    interface IJamesBondCar : ICar, IUnderwaterCar
    { void TurboBoost(); }
}



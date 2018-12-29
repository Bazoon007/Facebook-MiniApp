using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex01.Services;

namespace Ex01.UI
{
    internal interface IFeatureFrom
    {
        FacebookFeature FacebookFeature { get; }

        void InitFeatureForm();

        void ExecuteFeature();

        void Show();
    }
}

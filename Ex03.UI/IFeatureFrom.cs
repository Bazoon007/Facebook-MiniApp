using Ex03.Services;

namespace Ex03.UI
{
    internal interface IFeatureFrom
    {
        FacebookFeature FacebookFeature { get; }

        void InitFeatureForm();

        void ExecuteFeature();

        void Show();
    }
}

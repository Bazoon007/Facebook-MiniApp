using Ex02.Services;

namespace Ex02.UI
{
    internal interface IFeatureFrom
    {
        FacebookFeature FacebookFeature { get; }

        void InitFeatureForm();

        void ExecuteFeature();

        void Show();
    }
}

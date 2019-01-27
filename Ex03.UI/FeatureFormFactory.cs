using Ex03.Services;

namespace Ex03.UI
{
    internal class FeatureFormFactory
    {
        internal static IFeatureFrom CreateForm(UserFacade i_User, string i_ButtonName)
        {
            IFeatureFrom form = null;
            if (i_ButtonName == "buttonAlbumScanner")
            {
                form = new AlbumScannerForm(i_User);
            }
            else if (i_ButtonName == "buttonBlastFromThePast")
            {
                form = new BlastFromThePastForm(i_User);
            }

            return form;
        }
    }
}

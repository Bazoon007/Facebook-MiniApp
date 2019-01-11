using Ex03.Services;

namespace Ex03.UI
{
    internal class FeatureFormFactory
    {
        public static IFeatureFrom CreateForm(UserFacade i_User, string i_BtnName)
        {
            IFeatureFrom form = null;
            if (i_BtnName == "buttonAlbumScanner")
            {
                form = new AlbumScannerForm(i_User);
            }
            else if (i_BtnName == "buttonBlastFromThePast")
            {
                form = new BlastFromThePastForm(i_User);
            }

            return form;
        }
    }
}

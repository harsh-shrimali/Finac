using Finac.Debugging;

namespace Finac
{
    public class FinacConsts
    {
        public const string LocalizationSourceName = "Finac";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d4994c8400ba402f87096ce399c377a5";
    }
}

using OWML.Common;
using OWML.ModHelper;

namespace OuterWildsGR
{
	public class OuterWildsGR : ModBehaviour
	{
		public static OuterWildsGR Instance;

		private void Start()
		{
			// Starting here, you'll have access to OWML's mod helper.
			ModHelper.Console.WriteLine($"My mod {nameof(OuterWildsGR)} is loaded!", MessageType.Success);
			var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
			api.RegisterLanguage(this,"Greek", "assets/Translation.xml");
			api.AddLanguageFont(this,"Greek","assets/murecho-medium","Assets/Murecho-Medium.otf");
		}
	}
}

using Reloaded.Mod.Interfaces.Structs;
using System.ComponentModel;
using Yosuke_Romance.Template.Configuration;

namespace Yosuke_Romance.Configuration
{
	public class Config : Configurable<Config>
	{
		/*
            User Properties:
                - Please put all of your configurable properties here.

            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs

            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

		[DisplayName("Full Mod")]
		[Description("It's the Full Mod!")]
		[DefaultValue(true)]
		public bool Full { get; set; } = true;

		[DisplayName("Only Rank 10")]
		[Description("Just Rank 10 Confession")]
		[DefaultValue(true)]
		public bool Rank10 { get; set; } = true;

		[DisplayName("Rank 10 and Camp")]
		[Description("It's just Rank 10 and Camp Scene!")]
		[DefaultValue(true)]
		public bool Camp { get; set; } = true;

		[DisplayName("Only S-Link")]
		[Description("Only the S-Link!")]
		[DefaultValue(true)]
		public bool Slink { get; set; } = true;

		[DisplayName("Testing")]
		[Description("Stuff for Testing")]
		[DefaultValue(true)]
		public bool Testicle { get; set; } = true;

	}

	/// <summary>
	/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
	/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
	/// </summary>
	public class ConfiguratorMixin : ConfiguratorMixinBase
	{
		// 
	}
}
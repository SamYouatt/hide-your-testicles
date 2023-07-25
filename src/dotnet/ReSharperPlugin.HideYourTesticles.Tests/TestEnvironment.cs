using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.HideYourTesticles.Tests
{
    [ZoneDefinition]
    public class HideYourTesticlesTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IHideYourTesticlesZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<HideYourTesticlesTestEnvironmentZone> { }

    [SetUpFixture]
    public class HideYourTesticlesTestsAssembly : ExtensionTestEnvironmentAssembly<HideYourTesticlesTestEnvironmentZone> { }
}

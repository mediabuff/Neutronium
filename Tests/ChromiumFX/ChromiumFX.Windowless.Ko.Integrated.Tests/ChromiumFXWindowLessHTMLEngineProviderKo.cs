﻿using KnockoutUIFramework.Test.IntegratedInfra;
using Tests.ChromiumFX.Infra;
using Tests.Infra.HTMLEngineTesterHelper.Context;
using Tests.Infra.IntegratedContextTesterHelper.Windowless;
using Tests.Infra.JavascriptEngineTesterHelper;

namespace ChromiumFX.Windowless.Ko.Integrated.Tests
{
    public class ChromiumFXWindowLessHTMLEngineProviderKo : WindowLessHTMLEngineProvider
    {
        private static FrameworkTestContext KoTestContext { get; } = KnockoutFrameworkTestContext.GetKnockoutFrameworkTestContext();
        public override FrameworkTestContext FrameworkTestContext { get; } = KoTestContext;
        protected override IBasicWindowLessHTMLEngineProvider GetBasicWindowLessHTMLEngineProvider() => new ChromiumFXWindowLessHTMLEngineProvider(KoTestContext.HtmlProvider);
    }
}

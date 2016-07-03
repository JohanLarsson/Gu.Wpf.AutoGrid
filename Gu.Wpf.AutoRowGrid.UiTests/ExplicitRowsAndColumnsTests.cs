﻿using System.Diagnostics.Contracts;

namespace Gu.Wpf.AutoRowGrid.UiTests
{
    using NUnit.Framework;

    public class ExplicitRowsAndColumnsTests : WindowTest
    {
        public override string Title { get; } = "ExplicitRowsAndColumnsWindow";
        [Test]
        public void Bounds()
        {
            Assert.AreEqual("6,1 36,19", this.Window.GetTextBoxPosition("R0C0"));
            Assert.AreEqual("36,1 178,19", this.Window.GetTextBoxPosition("R0C1"));
            Assert.AreEqual("6,19 36,37", this.Window.GetTextBoxPosition("R1C0"));
            Assert.AreEqual("36,19 178,37", this.Window.GetTextBoxPosition("R1C1"));
        }
    }
}
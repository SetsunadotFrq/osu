// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using NUnit.Framework;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Osu.Difficulty;
using osu.Game.Rulesets.Osu.Mods;
using osu.Game.Tests.Beatmaps;

namespace osu.Game.Rulesets.Osu.Tests
{
    [TestFixture]
    public class OsuDifficultyCalculatorTest : DifficultyCalculatorTest
    {
        protected override string ResourceAssembly => "osu.Game.Rulesets.Osu";

        [TestCase(6.4766744062777439d, "diffcalc-test")]
        [TestCase(0.63190213974653298d, "zero-length-sliders")]
        public void Test(double expected, string name)
            => base.Test(expected, name);

        [TestCase(8.9926029916156764d, "diffcalc-test")]
        [TestCase(0.78116445583636385d, "zero-length-sliders")]
        public void TestClockRateAdjusted(double expected, string name)
            => Test(expected, name, new OsuModDoubleTime());

        protected override DifficultyCalculator CreateDifficultyCalculator(WorkingBeatmap beatmap) => new OsuDifficultyCalculator(new OsuRuleset(), beatmap);

        protected override Ruleset CreateRuleset() => new OsuRuleset();
    }
}

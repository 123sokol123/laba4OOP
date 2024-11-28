namespace StressTest
{
    /// <summary>
    /// Enumeration of girder material types
    /// </summary>
    public enum Material
    {
        StainlessSteel, // Stainless Steel
        Aluminium, // Aluminum
        ReinforcedConcrete, // Reinforced Concrete
        Composite, // Composite
        Titanium // Titanium
    }

    /// <summary>
    /// Enumeration of girder cross-sections
    /// </summary>
    public enum CrossSection
    {
        IBeam, // I-Beam
        Box, // Box
        ZShaped, // Z-Shaped
        CShaped // C-Shaped
    }

    /// <summary>
    /// Enumeration of test results
    /// </summary>
    public enum TestResult
    {
        Pass, // Pass
        Fail // Fail
    }
}

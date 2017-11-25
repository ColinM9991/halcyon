using System;

namespace Halcyon.HAL {
    [Obsolete("Will be removed in version 4.0.0, use HALModelConfig instead")]
    public interface IHALModelConfig {
        string LinkBase { get;  }
        bool ForceHAL { get; }
        bool CaseInsensitiveParameterNames { get; }
    }
}
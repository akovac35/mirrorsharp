﻿using System;
using System.Collections.Immutable;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using MirrorSharp.Advanced;
using MirrorSharp.Internal;

namespace MirrorSharp {
    [PublicAPI]
    public sealed class MirrorSharpOptions : IConnectionOptions, IWorkSessionOptions {
        public Func<string, ParseOptions> GetDefaultParseOptionsByLanguageName { get; set; }
        public Func<string, CompilationOptions> GetDefaultCompilationOptionsByLanguageName { get; set; }
        public Func<string, ImmutableList<MetadataReference>> GetDefaultMetadataReferencesByLanguageName { get; set; }
        [CanBeNull] public ISlowUpdateExtension SlowUpdate { get; set; }
        [CanBeNull] public ISetOptionsFromClientExtension SetOptionsFromClient { get; set; }
        public bool IncludeExceptionDetails { get; set; }
        public bool SelfDebugEnabled { get; set; }
    }
}

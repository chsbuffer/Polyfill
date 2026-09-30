#if !FeatureMemory || !FeatureValueTask
#error PackageReference features were not detected.
#endif

namespace ConsumeOldStyle;

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Polyfills;

static class StreamUsage
{
    public static int Read(Stream stream, Span<byte> buffer) => stream.Read(buffer);

    public static void ReadExactly(Stream stream, Span<byte> buffer) => stream.ReadExactly(buffer);

    public static ValueTask<int> ReadAsync(Stream stream, Memory<byte> buffer) =>
        stream.ReadAsync(buffer, CancellationToken.None);
}

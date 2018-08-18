# x264-winbench

A Windows app for determining which x264 presets your CPU is capable of using for real-time encoding (e.g. live streaming), without skipping frames.

![screenshot](https://scratch.christianmoore.me/x264-winbench.png)

## Features

* Simple, one-click interface
* Easy to understand results
* Test up to 32 different resolution, framerate, and preset combinations

## Quick Start

1. Download the latest [.zip release](https://github.com/shamelesscookie/x264-winbench/releases)
2. If needed, install [.NET Framework 4.5.2](https://www.microsoft.com/net/download/thank-you/net452)
3. Extract and run x264-winbench.exe
4. Select which resolution/framerate combinations you'd like to test. Options are:

   * 720p30
   * 720p60
   * 1080p30
   * 1080p60

_Note: You cannot select individual presets._

1. Press `Start` and wait for the benchmark to run
2. Passing presets will be checked off as the benchmark runs. Failing presets will not be checked.

## Methodology

Bundled with the app is a fast motion, 10 second, 1080p120 22Mbps HEVC benchmark video. x264-winbench attempts to re-encode this video at various settings, and times how long the process takes. Presets that can re-encode the video in less than 10 seconds receive a passing check, as these should be capable of real-time encoding.
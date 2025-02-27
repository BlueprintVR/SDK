# SDK
Blueprint SDK for Unity only.

## Using Unity for developing Blueprint apps
Unity is the official supported game engine for Blueprint app development, however all Blueprint apps require the Blueprint SDK for the blueprintOS App Compiler to build and read your application.

When writting code and scripts inside Unity, it is required to use our Unity to Vulkan binding which can only be accessed via the Blueprint SDK. Since Unity supports C# Scripts only, the binding converts C# into Vulkan/C++ code. If you use other languages for your app, you can use a binding included in the SDK (If we have provided it) or create your own if there isn't available for the specific language you are targeting.

## UI Frameworks for Blueprint apps
The official UI framework for Blueprint apps is CoreVR, it's framework source code is included in the Blueprint SDK, and does not require seperate installation. The framework's source code is in a mix of directories that are shared between other tools in Blueprint's SDK.

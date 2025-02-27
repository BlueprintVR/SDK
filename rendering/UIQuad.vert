#version 450

layout(location = 0) in vec2 inPosition;   // Quad vertex position (x, y)
layout(location = 1) in vec2 inTexCoord;   // Texture coordinates (u, v)

layout(location = 0) out vec2 fragTexCoord; // Pass texture coordinates to fragment shader

layout(push_constant) uniform PushConstants {
    vec2 screenSize;  // Needed for proper positioning in NDC
} pc;

void main() {
    // Convert from screen space to NDC (-1 to 1 range)
    vec2 pos = (inPosition / pc.screenSize) * 2.0 - 1.0;
    pos.y = -pos.y; // Flip Y-axis to match Vulkan's coordinate system

    gl_Position = vec4(pos, 0.0, 1.0);
    fragTexCoord = inTexCoord;
}

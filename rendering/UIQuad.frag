#version 450

layout(location = 0) in vec2 fragTexCoord;  // Received texture coordinates
layout(location = 0) out vec4 outColor;     // Output pixel color

layout(binding = 0) uniform sampler2D uiTexture;  // UI texture
layout(push_constant) uniform PushConstants {
    vec4 uiColor;  // UI element color (RGBA)
} pc;

void main() {
    vec4 texColor = texture(uiTexture, fragTexCoord);
    outColor = texColor * pc.uiColor; // Blend texture with UI color
}

#version 410 core

in vec3 FragC;
in vec3 FragP;
in vec2 aUV;

out vec4 Result;

uniform sampler2D cactus;

void main() {
   Result = texture(cactus, aUV) * vec4(FragC, 1.0);
}

#version 330 core
in vec2 v_uv0;
uniform sampler2D ourTexture;
out vec4 FragColor;
void main()
{
    FragColor = texture(ourTexture, v_uv0);
};
#version 330 core
in vec2 v_uv0;
uniform sampler2D ourTexture0;
uniform sampler2D ourTexture1;
out vec4 FragColor;
void main()
{
    vec4 pixel0 = texture(ourTexture0, v_uv0);
    vec4 pixel1 = texture(ourTexture1, vec2(1.0 - v_uv0.x, v_uv0.y));
    FragColor = mix(pixel0, pixel1, 0.2);
};
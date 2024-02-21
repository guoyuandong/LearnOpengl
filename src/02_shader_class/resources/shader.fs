#version 330 core
in vec3 v_Pos;
out vec4 FragColor;
void main()
{
    FragColor = vec4(v_Pos, 1.0f);
};
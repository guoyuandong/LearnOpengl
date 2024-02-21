#version 330 core
layout (location = 0) in vec3 a_Pos;
out vec3 v_Pos;
uniform float u_offset;
void main()
{
   v_Pos = a_Pos;
   gl_Position = vec4(a_Pos.x + u_offset, -a_Pos.y, a_Pos.z, 1.0);
};
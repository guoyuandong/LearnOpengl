#version 330 core
layout (location = 0) in vec3 a_Pos;
layout (location = 1) in vec2 a_uv0;
out vec2 v_uv0;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
   v_uv0 = a_uv0;
   gl_Position = projection*view*model*vec4(a_Pos, 1.0);
};
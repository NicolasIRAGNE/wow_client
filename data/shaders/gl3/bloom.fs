#version 330

in fs_block
{
	vec2 fs_uv;
};

layout(location=0) out vec4 fragcolor;

uniform sampler2D color_tex;

layout(std140) uniform model_block
{
	mat4 mvp;
	float threshold;
};

void main()
{
	vec3 texture_color = texture(color_tex, fs_uv).xyz;
	float brightness = dot(texture_color, vec3(0.2126, 0.7152, 0.0722));
	if (brightness >= threshold)
		fragcolor = vec4(texture_color, 1);
	else
		fragcolor = vec4(0);
}

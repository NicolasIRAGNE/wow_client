struct pixel_input
{
	float2 uv : FS_INPUT0;
};

float4 main(pixel_input input) : SV_TARGET
{
	return float4(0, 1, 0, 1);
}

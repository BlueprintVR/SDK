struct UIQuadVertex
{
    public Vector2 position;
    public Vector2 texCoord;
}

VkBuffer vertexBuffer;
VkDeviceMemory vertexMemory;

void CreateUIVertexBuffer(VkDevice device)
{
    UIQuadVertex[] vertices = new UIQuadVertex[]
    {
        new UIQuadVertex { position = new Vector2(0, 0), texCoord = new Vector2(0, 0) },
        new UIQuadVertex { position = new Vector2(100, 0), texCoord = new Vector2(1, 0) },
        new UIQuadVertex { position = new Vector2(100, 100), texCoord = new Vector2(1, 1) },
        new UIQuadVertex { position = new Vector2(0, 100), texCoord = new Vector2(0, 1) }
    };

    // Create Vulkan buffer
    VkBufferCreateInfo bufferInfo = new VkBufferCreateInfo
    {
        sType = VkStructureType.BufferCreateInfo,
        size = (ulong)(vertices.Length * Marshal.SizeOf(typeof(UIQuadVertex))),
        usage = VkBufferUsageFlags.VertexBuffer,
        sharingMode = VkSharingMode.Exclusive
    };

    VulkanNative.vkCreateBuffer(device, ref bufferInfo, IntPtr.Zero, out vertexBuffer);
}

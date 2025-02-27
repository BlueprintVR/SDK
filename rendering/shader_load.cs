VkShaderModule LoadShaderModule(VkDevice device, string shaderPath)
{
    byte[] shaderCode = File.ReadAllBytes(shaderPath);
    VkShaderModuleCreateInfo createInfo = new VkShaderModuleCreateInfo
    {
        sType = VkStructureType.ShaderModuleCreateInfo,
        codeSize = (UIntPtr)shaderCode.Length,
        pCode = shaderCode
    };

    VkShaderModule shaderModule;
    VulkanNative.vkCreateShaderModule(device, ref createInfo, IntPtr.Zero, out shaderModule);
    return shaderModule;
}

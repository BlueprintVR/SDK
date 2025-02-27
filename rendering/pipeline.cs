VkPipeline CreateUIPipeline(VkDevice device, VkRenderPass renderPass)
{
    VkPipelineShaderStageCreateInfo[] shaderStages = new VkPipelineShaderStageCreateInfo[2];

    shaderStages[0] = new VkPipelineShaderStageCreateInfo
    {
        sType = VkStructureType.PipelineShaderStageCreateInfo,
        stage = VkShaderStageFlags.Vertex,
        module = vertShader,
        pName = "main"
    };

    shaderStages[1] = new VkPipelineShaderStageCreateInfo
    {
        sType = VkStructureType.PipelineShaderStageCreateInfo,
        stage = VkShaderStageFlags.Fragment,
        module = fragShader,
        pName = "main"
    };

    VkPipelineLayoutCreateInfo pipelineLayoutInfo = new VkPipelineLayoutCreateInfo
    {
        sType = VkStructureType.PipelineLayoutCreateInfo
    };

    VkPipelineLayout pipelineLayout;
    VulkanNative.vkCreatePipelineLayout(device, ref pipelineLayoutInfo, IntPtr.Zero, out pipelineLayout);

    VkGraphicsPipelineCreateInfo pipelineInfo = new VkGraphicsPipelineCreateInfo
    {
        sType = VkStructureType.GraphicsPipelineCreateInfo,
        stageCount = (uint)shaderStages.Length,
        pStages = shaderStages,
        layout = pipelineLayout,
        renderPass = renderPass
    };

    VkPipeline pipeline;
    VulkanNative.vkCreateGraphicsPipelines(device, IntPtr.Zero, 1, ref pipelineInfo, IntPtr.Zero, out pipeline);
    return pipeline;
}

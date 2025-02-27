void RenderUI(VkCommandBuffer commandBuffer, VkPipeline pipeline, VkBuffer vertexBuffer)
{
    VulkanNative.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.Graphics, pipeline);

    VkDeviceSize offset = 0;
    VulkanNative.vkCmdBindVertexBuffers(commandBuffer, 0, 1, ref vertexBuffer, ref offset);

    VulkanNative.vkCmdDraw(commandBuffer, 4, 1, 0, 0);
}

void RenderUIBatch(VkCommandBuffer commandBuffer, VkPipeline pipeline, VkBuffer vertexBuffer, int quadCount)
{
    VulkanNative.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.Graphics, pipeline);
    
    VkDeviceSize offset = 0;
    VulkanNative.vkCmdBindVertexBuffers(commandBuffer, 0, 1, ref vertexBuffer, ref offset);

    // Draw all UI quads in one call
    VulkanNative.vkCmdDraw(commandBuffer, quadCount * 4, 1, 0, 0);
}

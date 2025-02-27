void RenderUI(VkCommandBuffer commandBuffer, VkPipeline pipeline, VkBuffer vertexBuffer)
{
    VulkanNative.vkCmdBindPipeline(commandBuffer, VkPipelineBindPoint.Graphics, pipeline);

    VkDeviceSize offset = 0;
    VulkanNative.vkCmdBindVertexBuffers(commandBuffer, 0, 1, ref vertexBuffer, ref offset);

    VulkanNative.vkCmdDraw(commandBuffer, 4, 1, 0, 0);
}

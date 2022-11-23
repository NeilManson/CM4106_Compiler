namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to a while command
    /// </summary>
    public class LoopCommandNode : ICommandNode
    {
        /// <summary>
        /// The condition associated with the loop
        /// </summary>
        public IExpressionNode Expression { get; }

        /// <summary>
        /// The command inside the loop
        /// </summary>
        public ICommandNode LoopCommand { get; }

        /// <summary>
        /// The command inside the loop
        /// </summary>
        public ICommandNode WhileCommand { get; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// Creates a new while node
        /// </summary>
        /// <param name="expression">The condition associated with the loop</param>
        /// <param name="command">The command inside the loop</param>
        /// <param name="position">The position in the code where the content associated with the node begins</param>
        public LoopCommandNode(ICommandNode command, IExpressionNode expression, ICommandNode command2,  Position position)
        {
            LoopCommand = command;
            Expression = expression;
            WhileCommand= command2;
            Position = position;
        }
    }
}
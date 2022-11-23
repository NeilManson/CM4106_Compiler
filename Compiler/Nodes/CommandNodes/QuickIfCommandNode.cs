namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to an if command
    /// </summary>
    public class QuickIfCommandNode : ICommandNode
    {
        /// <summary>
        /// The condition expression
        /// </summary>
        public IExpressionNode Expression { get; }

        /// <summary>
        /// The do branch command
        /// </summary>
        public ICommandNode DoCommand { get; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// Creates a new if command node
        /// </summary>
        /// <param name="expression">The condition expression</param>
        /// <param name="thenCommand">The then branch command</param>
        /// <param name="elseCommand">The else branch command</param>
        /// <param name="position">The position in the code where the content associated with the node begins</param>
        public QuickIfCommandNode(IExpressionNode expression, ICommandNode doCommand, Position position)
        {
            Expression = expression;
            DoCommand = doCommand;
            Position = position;
        }
    }
}
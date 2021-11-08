# Dserve assignment: SnakeAndLadder

## Running programme and test

```shell
# Run the programme.
dotnet build
dotnet run
```

```shell
# Run the tests

# Execute all tests
cd SnakeLadderGameEngine.Tests
dotnet test

# Execute specific test
dotnet test --filter DisplayName = "*ex <SnakeLadderGameEngine.Tests.LadderTests.MovePlayer_PlayerShouldMoveFrom8to24>"

```

## Notes

### Assumptions made

This implementation makes the following assumptions in the code:

1. Game is build with a single die.
2. Player starts the game at position 1 and there is no sperate start position cell in the game.

### Testing

1. Xunit is used for automated unit testing.

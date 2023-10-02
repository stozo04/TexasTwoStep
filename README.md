# Lottery Simulation Console Application

## Overview
This console application simulates a lottery game to determine how many drawings it would take for specific numbers to win the jackpot. The lottery game consists of choosing four unique numbers from 1 to 35 and one bonus ball number from 1 to 35. The application continues to simulate drawings until the selected numbers hit the jackpot.

## Features
- Simulates lottery drawings with four unique numbers and one bonus ball number.
- Tracks the total cost and total winnings over time.
- Outputs the results after every 100,000 drawings for progress tracking.
- Continues simulation until the selected numbers win the jackpot.

## How to Use
1. Open the project in your preferred C# development environment.
2. Ensure your selected numbers and bonus ball number are correctly set in the `MyNumbers` and `MyBonusBall` variables.
3. Run the application.
4. The application will output the progress after every 100,000 drawings and will notify you once it hits the jackpot, displaying the total cost and total winnings.

## Selected Numbers
- Regular Numbers: 5, 13, 22, 33
- Bonus Ball: 27

## Output
The application will output the following information:
- The number of drawings after every 100,000 simulations.
- The total cost and total winnings after every 100,000 simulations.
- Notification of hitting the jackpot, along with the total cost and total winnings at that point.

## Example Output
After 100,000 drawings, Total Cost: $100,000, Total Won: $29,202
...
Hit the Jackpot after 1,235,955 drawings!
Total Cost: $1,235,955, Total Won: $856,176

## Note
This is a basic simulation and does not account for various real-world factors such as taxes, interest, inflation, or changes in lottery rules. It is intended for entertainment and educational purposes only.


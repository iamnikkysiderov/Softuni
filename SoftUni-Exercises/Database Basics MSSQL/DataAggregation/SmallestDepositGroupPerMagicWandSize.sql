SELECT TOP 2 DepositGroup, AVG(MagicWandSize) FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize) ASC
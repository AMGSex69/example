int[] array = { 71, 25, 36, 45, 81, 54, 63, 72, 81 };

int n = array.Length;
int find = 81;

int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}

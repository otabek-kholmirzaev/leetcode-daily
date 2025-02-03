var maxAscendingSum = function (nums) {
  let sum = 0;
  nums.push(0);
  let cur = nums[0];
  for (let i = 1; i < nums.length; i++) {
    if (nums[i] <= nums[i - 1]) {
      sum = Math.max(sum, cur);
      cur = 0;
    }

    cur += nums[i];
  }

  return sum;
};

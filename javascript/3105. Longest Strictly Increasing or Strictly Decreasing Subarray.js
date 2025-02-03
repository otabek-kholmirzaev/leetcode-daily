var longestMonotonicSubarray = function (nums) {
  let longest = 0;

  // check for increasing
  nums.push(0);
  let l = 0;
  for (let i = 1; i < nums.length; i++) {
    if (nums[i] <= nums[i - 1]) {
      longest = Math.max(longest, i - l);
      l = i;
    }
  }

  nums.pop();

  // check for decreasing
  nums.push(51);
  l = 0;
  for (let i = 1; i < nums.length; i++) {
    if (nums[i] >= nums[i - 1]) {
      longest = Math.max(longest, i - l);
      l = i;
    }
  }

  return longest;
};

<script lang="ts">
import { CURRENCY_PAIR } from '@/constants.js';
export default {
   name: 'MultiselectCurrencyPair',

   computed: {
      currencyPairs(): string[] {
         return Object.values(CURRENCY_PAIR);
      },
   },
}
</script>
<template>
   <v-autocomplete
      label="Pair"
      :items="currencyPairs"
   ></v-autocomplete>
</template>
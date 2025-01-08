<script lang="ts">
import { RESULT_TYPES } from '@/constants.js';
export default {
   name: 'MultiselectResultType',
   
   computed: {
      resultTypes(): string[] {
         return Object.values(RESULT_TYPES).map(type => type.name);
      },
   },
}
</script>
<template>
   <v-autocomplete
      label="Result"
      :items="resultTypes"
   ></v-autocomplete>
</template>
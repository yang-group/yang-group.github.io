<template>
    <div class="lighten-2">
      <v-container>
        <v-row>
          <template v-for="(value,key,index) in std_cat" >
            <v-col
              :key="index"
              class="mt-2"
              cols="12"
              v-show="value.length != 0"
            >
              <h2>{{ key }}</h2>
            </v-col>

            <v-col
              v-for="(stu,idx) in value"
              :key="`${key}${idx}`"
              cols="auto"
              md="3"
            >
              <v-sheet>
                <Student :stu="stu" />
              </v-sheet>
            </v-col>
          </template>
        </v-row>
      </v-container>
    </div>
</template>

<script>
import Student from '@/components/Student'

export default {
  props: ['memberData'],
  components: {
    Student
  },
  data: () => ({
    std_cat: {}
  }),
  mounted () {
    this.std_cat = this.memberData
  }
}
</script>

<style>

</style>
